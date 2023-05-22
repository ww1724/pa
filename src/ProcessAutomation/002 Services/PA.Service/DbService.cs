﻿using ATE.Common.Entities;
using PA.Service.Interface;
using SqlSugar;
using System.Configuration;

namespace PA.Service
{
    public class DbService : IDbService, IServiceBase
    {
        public string Name => "DbService";

        public string Description => "Provide DbService of Sqlite";

        public ServiceState ServiceState { get; set; } = ServiceState.Uninit;

        private string DbConnectionString => ConfigurationManager.ConnectionStrings["MysqlConnectionString"].ConnectionString;

        private DbType DbType => DbType.MySql;

        private SqlSugarClient sugarClient { get; set; }
 
        public DbService()
        {
            sugarClient = new SqlSugarClient(new ConnectionConfig
            {
                ConnectionString = DbConnectionString,
                DbType = DbType
            });
            InitTables();
            ServiceState = ServiceState.Running;
        }

        private void InitTables()
        {
            sugarClient.DbMaintenance.CreateDatabase();
            sugarClient.CodeFirst.InitTables(
                typeof(ProductEntity),
                typeof(UserEntity),
                typeof(TestingCodeEntity));

                //typeof(GeneralDataEntity),
                //typeof(ConfigurationEntity),

                
                //typeof(TestingDataEntity),
                //typeof(TestingProject),
                //typeof(TestingAction),
                //typeof(TestingRecord),
                //typeof(ProductEntity));

            //if (!sugarClient.Queryable<UserEntity>().Any())
            //{
            //    sugarClient.InsertableByObject(new UserEntity
            //    {
            //        Name = "Zoran.Yang",
            //        Role = "SuperAdmin",
            //        Passwd = "db49172",
            //    }).ExecuteCommand();
            //}
        }

        /// <summary>
        /// 通用查询
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="condition">查询条件</param>
        /// <returns></returns>
        public List<T> Query<T>(string condition = "")
        {
            return sugarClient.Queryable<T>().ToList();
        }

        /// <summary>
        /// 插入数据
        /// </summary>
        /// <typeparam name="T">数据类型</typeparam>
        /// <param name="entity">数据实体</param>
        /// <returns></returns>
        public int Insert<T>(T entity)
        {
            return sugarClient.InsertableByObject(entity).ExecuteCommand();
        }


        /// <summary>
        /// 更新数据
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entity">数据实体</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public int Update<T>(T entity)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// 删除数据
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entity">数据实体</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public int Delete<T>(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
