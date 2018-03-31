using MySql.Data.MySqlClient;
using NPoco;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace MP_TD.Base
{
    public class BaseDepot<TEntity, TId>
        where TEntity : BaseEntity<TId>
    {
        private const string connectionString = "Server=192.168.0.15; Port=3307; Database=TDM; Uid=TDM_User; Pwd=xh3OUidgofLBj4d8;";

        protected IDatabase Database;
        protected string TableName = typeof(TEntity).Name;

        public BaseDepot()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            Database = new Database(connection);
        }

        public TEntity GetById(TId id)
        {
            return Database.Fetch<TEntity>(GetBaseSelectSql().Where("Id = @Id", new { Id = id })).FirstOrDefault();
        }

        public void Delete(TId id)
        {
            Sql delete = Sql.Builder.Append($"DELETE FROM {TableName} WHERE Id = @Id", new { Id = id });

            Database.Execute(delete);
        }

        public void Save(TEntity entity)
        {

        }


        protected Sql GetBaseSelectSql()
        {
            return Sql.Builder.Select("*").From(TableName);
        }
    }
}
