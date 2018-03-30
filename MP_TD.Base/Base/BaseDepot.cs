using NPoco;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace MP_TD.Base
{
    public class BaseDepot<TEntity, TId>
        where TEntity : BaseEntity<TId>
    {
        private const string connectionString = "Server=127.0.0.1;Database=TDM;Uid=root;Pwd=;";
        protected IDatabase Database;
        protected string TableName = typeof(TEntity).Name;

        public BaseDepot()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            Database = new Database(connectionString, DatabaseType.MySQL);
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
