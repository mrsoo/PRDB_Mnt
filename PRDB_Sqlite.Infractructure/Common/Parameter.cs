﻿using System.Collections.Generic;
using System.Configuration;

namespace PRDB_Sqlite.Infractructure.Common
{
    public class Parameter
    {
        #region Tra_Prop
        private static string _connectionString;
        private static float _eulerThreshold;
        private static string _curStrategy;

        #endregion
        #region Tra_get_seter
        public static string connectionString
        {
            get => string.IsNullOrEmpty(_connectionString) ? ConfigurationManager.AppSettings["conectionString"].ToString() : _connectionString;
            set => _connectionString = value;
        }
        public static float eulerThreshold
        {
            get => (_eulerThreshold == 0f) ? 0.01f : _eulerThreshold;
            set => _eulerThreshold = value;
        }
        public static string curStrategy
        {
            set
            {
                _curStrategy = value;
            }
            get
            {
                if (string.IsNullOrEmpty(_curStrategy))
                    return "⊗_in";
                return _curStrategy;
            }
        }

        #endregion
        #region param presentation
        public static bool indexSchChange { get; set; }
        public static bool indexRelChange { get; set; }
        public static int SchemaIndex { get; set; }
        public static int RelationIndex { get; set; }
        public static int activeTabIdx { get; set; }

        public static IList<string> datatype
        {
            get
            {
                return new List<string>()
                {
                    "Int16",
                    "Int32",
                    "Int64",
                    "Byte",
                    "String",
                    "DateTime",
                    "Decimal",
                    "Single",
                    "Double",
                    "Boolean",
                    "Binary",
                    "Currency",
                    "UserDefined"
                };
            }
        }
        public static IList<string> strategies
        {
            get
            {
                return new List<string> {
                    "⊕_in", "⊕_ig", "⊕_me","⊗_in", "⊗_ig", "⊗_me"
                };
            }
        }
        #endregion
    }
}
