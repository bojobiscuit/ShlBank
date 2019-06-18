using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using Repository.Dtos;
using Repository.Interfaces;

namespace Repository.Implementations
{
    public class UserRepository : IUserRepository
    {
        private readonly ShlContext db;

        public UserRepository(ShlContext db)
        {
            this.db = db;
        }

        public UserAccountDto GetUserAccount(int id)
        {
            UserAccountDto userAccount;

            try
            {
                if (!db.Connection.Ping())
                {
                    db.Connection.Open();
                }

                string sql =
                // @"SELECT username, bankbalance, teamid, claimedFreeTraining 
                //     FROM mybb_users WHERE uid=@uid LIMIT 1";
                @"SELECT username 
                    FROM mybb_users WHERE uid=@uid LIMIT 1";

                MySqlCommand command = new MySqlCommand(sql, db.Connection);
                command.Parameters.AddWithValue("@uid", id);
                MySqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    userAccount = new UserAccountDto()
                    {
                        Id = id,
                        UserName = (string)reader["username"],
                        // Balance = (int)reader["bankbalance"],
                        // TeamId = (int?)reader["teamid"],
                        // HasClaimedFree500 = (bool)reader["claimedFreeTraining"],
                    };
                    // userAccount.IsBanker = false;
                    // userAccount.CanDoShlTraining = userAccount.TeamId != null;
                }
                else throw new Exception();

                reader.Close();
            }
            catch (Exception ex)
            {
                userAccount = null;
            }
            finally
            {
                db.Connection.Close();
            }

            return userAccount;
        }
    }
}
