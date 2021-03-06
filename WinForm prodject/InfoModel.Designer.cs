﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
namespace WinForm_prodject
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class WebDataBaseEntities2 : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new WebDataBaseEntities2 object using the connection string found in the 'WebDataBaseEntities2' section of the application configuration file.
        /// </summary>
        public WebDataBaseEntities2() : base("name=WebDataBaseEntities2", "WebDataBaseEntities2")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new WebDataBaseEntities2 object.
        /// </summary>
        public WebDataBaseEntities2(string connectionString) : base(connectionString, "WebDataBaseEntities2")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new WebDataBaseEntities2 object.
        /// </summary>
        public WebDataBaseEntities2(EntityConnection connection) : base(connection, "WebDataBaseEntities2")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Info> Infoes
        {
            get
            {
                if ((_Infoes == null))
                {
                    _Infoes = base.CreateObjectSet<Info>("Infoes");
                }
                return _Infoes;
            }
        }
        private ObjectSet<Info> _Infoes;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Infoes EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToInfoes(Info info)
        {
            base.AddObject("Infoes", info);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="WebDataBaseModel", Name="Info")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Info : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Info object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        public static Info CreateInfo(global::System.Int32 id)
        {
            Info info = new Info();
            info.Id = id;
            return info;
        }

        #endregion

        #region Simple Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value, "Id");
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String HaveStudiedOn
        {
            get
            {
                return _HaveStudiedOn;
            }
            set
            {
                OnHaveStudiedOnChanging(value);
                ReportPropertyChanging("HaveStudiedOn");
                _HaveStudiedOn = StructuralObject.SetValidValue(value, true, "HaveStudiedOn");
                ReportPropertyChanged("HaveStudiedOn");
                OnHaveStudiedOnChanged();
            }
        }
        private global::System.String _HaveStudiedOn;
        partial void OnHaveStudiedOnChanging(global::System.String value);
        partial void OnHaveStudiedOnChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Expirience
        {
            get
            {
                return _Expirience;
            }
            set
            {
                OnExpirienceChanging(value);
                ReportPropertyChanging("Expirience");
                _Expirience = StructuralObject.SetValidValue(value, true, "Expirience");
                ReportPropertyChanged("Expirience");
                OnExpirienceChanged();
            }
        }
        private global::System.String _Expirience;
        partial void OnExpirienceChanging(global::System.String value);
        partial void OnExpirienceChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Knowlege
        {
            get
            {
                return _Knowlege;
            }
            set
            {
                OnKnowlegeChanging(value);
                ReportPropertyChanging("Knowlege");
                _Knowlege = StructuralObject.SetValidValue(value, true, "Knowlege");
                ReportPropertyChanged("Knowlege");
                OnKnowlegeChanged();
            }
        }
        private global::System.String _Knowlege;
        partial void OnKnowlegeChanging(global::System.String value);
        partial void OnKnowlegeChanged();

        #endregion

    }

    #endregion

}
