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
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("TestePraticoModel", "FK_tbCidadetbEstado", "tbEstado", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(WebServiceMVC.Models.tbEstado), "tbCidade", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(WebServiceMVC.Models.tbCidade), true)]

#endregion

namespace WebServiceMVC.Models
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class TestePraticoEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new TestePraticoEntities object using the connection string found in the 'TestePraticoEntities' section of the application configuration file.
        /// </summary>
        public TestePraticoEntities() : base("name=TestePraticoEntities", "TestePraticoEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new TestePraticoEntities object.
        /// </summary>
        public TestePraticoEntities(string connectionString) : base(connectionString, "TestePraticoEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new TestePraticoEntities object.
        /// </summary>
        public TestePraticoEntities(EntityConnection connection) : base(connection, "TestePraticoEntities")
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
        public ObjectSet<tbCidade> tbCidades
        {
            get
            {
                if ((_tbCidades == null))
                {
                    _tbCidades = base.CreateObjectSet<tbCidade>("tbCidades");
                }
                return _tbCidades;
            }
        }
        private ObjectSet<tbCidade> _tbCidades;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<tbEstado> tbEstadoes
        {
            get
            {
                if ((_tbEstadoes == null))
                {
                    _tbEstadoes = base.CreateObjectSet<tbEstado>("tbEstadoes");
                }
                return _tbEstadoes;
            }
        }
        private ObjectSet<tbEstado> _tbEstadoes;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<tbPessoa> tbPessoas
        {
            get
            {
                if ((_tbPessoas == null))
                {
                    _tbPessoas = base.CreateObjectSet<tbPessoa>("tbPessoas");
                }
                return _tbPessoas;
            }
        }
        private ObjectSet<tbPessoa> _tbPessoas;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<tbProduto> tbProdutoes
        {
            get
            {
                if ((_tbProdutoes == null))
                {
                    _tbProdutoes = base.CreateObjectSet<tbProduto>("tbProdutoes");
                }
                return _tbProdutoes;
            }
        }
        private ObjectSet<tbProduto> _tbProdutoes;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the tbCidades EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotbCidades(tbCidade tbCidade)
        {
            base.AddObject("tbCidades", tbCidade);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the tbEstadoes EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotbEstadoes(tbEstado tbEstado)
        {
            base.AddObject("tbEstadoes", tbEstado);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the tbPessoas EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotbPessoas(tbPessoa tbPessoa)
        {
            base.AddObject("tbPessoas", tbPessoa);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the tbProdutoes EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotbProdutoes(tbProduto tbProduto)
        {
            base.AddObject("tbProdutoes", tbProduto);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="TestePraticoModel", Name="tbCidade")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class tbCidade : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new tbCidade object.
        /// </summary>
        /// <param name="id">Initial value of the id property.</param>
        /// <param name="tbEstado_id">Initial value of the tbEstado_id property.</param>
        public static tbCidade CreatetbCidade(global::System.Int32 id, global::System.Int32 tbEstado_id)
        {
            tbCidade tbCidade = new tbCidade();
            tbCidade.id = id;
            tbCidade.tbEstado_id = tbEstado_id;
            return tbCidade;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 id
        {
            get
            {
                return _id;
            }
            set
            {
                if (_id != value)
                {
                    OnidChanging(value);
                    ReportPropertyChanging("id");
                    _id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("id");
                    OnidChanged();
                }
            }
        }
        private global::System.Int32 _id;
        partial void OnidChanging(global::System.Int32 value);
        partial void OnidChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Cidade
        {
            get
            {
                return _Cidade;
            }
            set
            {
                OnCidadeChanging(value);
                ReportPropertyChanging("Cidade");
                _Cidade = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Cidade");
                OnCidadeChanged();
            }
        }
        private global::System.String _Cidade;
        partial void OnCidadeChanging(global::System.String value);
        partial void OnCidadeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 tbEstado_id
        {
            get
            {
                return _tbEstado_id;
            }
            set
            {
                OntbEstado_idChanging(value);
                ReportPropertyChanging("tbEstado_id");
                _tbEstado_id = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("tbEstado_id");
                OntbEstado_idChanged();
            }
        }
        private global::System.Int32 _tbEstado_id;
        partial void OntbEstado_idChanging(global::System.Int32 value);
        partial void OntbEstado_idChanged();

        #endregion

    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("TestePraticoModel", "FK_tbCidadetbEstado", "tbEstado")]
        public tbEstado tbEstado
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<tbEstado>("TestePraticoModel.FK_tbCidadetbEstado", "tbEstado").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<tbEstado>("TestePraticoModel.FK_tbCidadetbEstado", "tbEstado").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<tbEstado> tbEstadoReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<tbEstado>("TestePraticoModel.FK_tbCidadetbEstado", "tbEstado");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<tbEstado>("TestePraticoModel.FK_tbCidadetbEstado", "tbEstado", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="TestePraticoModel", Name="tbEstado")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class tbEstado : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new tbEstado object.
        /// </summary>
        /// <param name="id">Initial value of the id property.</param>
        /// <param name="estado">Initial value of the Estado property.</param>
        public static tbEstado CreatetbEstado(global::System.Int32 id, global::System.String estado)
        {
            tbEstado tbEstado = new tbEstado();
            tbEstado.id = id;
            tbEstado.Estado = estado;
            return tbEstado;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 id
        {
            get
            {
                return _id;
            }
            set
            {
                if (_id != value)
                {
                    OnidChanging(value);
                    ReportPropertyChanging("id");
                    _id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("id");
                    OnidChanged();
                }
            }
        }
        private global::System.Int32 _id;
        partial void OnidChanging(global::System.Int32 value);
        partial void OnidChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Estado
        {
            get
            {
                return _Estado;
            }
            set
            {
                OnEstadoChanging(value);
                ReportPropertyChanging("Estado");
                _Estado = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Estado");
                OnEstadoChanged();
            }
        }
        private global::System.String _Estado;
        partial void OnEstadoChanging(global::System.String value);
        partial void OnEstadoChanged();

        #endregion

    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("TestePraticoModel", "FK_tbCidadetbEstado", "tbCidade")]
        public EntityCollection<tbCidade> tbCidades
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<tbCidade>("TestePraticoModel.FK_tbCidadetbEstado", "tbCidade");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<tbCidade>("TestePraticoModel.FK_tbCidadetbEstado", "tbCidade", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="TestePraticoModel", Name="tbPessoa")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class tbPessoa : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new tbPessoa object.
        /// </summary>
        /// <param name="id">Initial value of the id property.</param>
        /// <param name="tbCidade_id">Initial value of the tbCidade_id property.</param>
        public static tbPessoa CreatetbPessoa(global::System.Int32 id, global::System.Int32 tbCidade_id)
        {
            tbPessoa tbPessoa = new tbPessoa();
            tbPessoa.id = id;
            tbPessoa.tbCidade_id = tbCidade_id;
            return tbPessoa;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 id
        {
            get
            {
                return _id;
            }
            set
            {
                if (_id != value)
                {
                    OnidChanging(value);
                    ReportPropertyChanging("id");
                    _id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("id");
                    OnidChanged();
                }
            }
        }
        private global::System.Int32 _id;
        partial void OnidChanging(global::System.Int32 value);
        partial void OnidChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String nome
        {
            get
            {
                return _nome;
            }
            set
            {
                OnnomeChanging(value);
                ReportPropertyChanging("nome");
                _nome = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("nome");
                OnnomeChanged();
            }
        }
        private global::System.String _nome;
        partial void OnnomeChanging(global::System.String value);
        partial void OnnomeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String cpf
        {
            get
            {
                return _cpf;
            }
            set
            {
                OncpfChanging(value);
                ReportPropertyChanging("cpf");
                _cpf = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("cpf");
                OncpfChanged();
            }
        }
        private global::System.String _cpf;
        partial void OncpfChanging(global::System.String value);
        partial void OncpfChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String telefone
        {
            get
            {
                return _telefone;
            }
            set
            {
                OntelefoneChanging(value);
                ReportPropertyChanging("telefone");
                _telefone = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("telefone");
                OntelefoneChanged();
            }
        }
        private global::System.String _telefone;
        partial void OntelefoneChanging(global::System.String value);
        partial void OntelefoneChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String email
        {
            get
            {
                return _email;
            }
            set
            {
                OnemailChanging(value);
                ReportPropertyChanging("email");
                _email = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("email");
                OnemailChanged();
            }
        }
        private global::System.String _email;
        partial void OnemailChanging(global::System.String value);
        partial void OnemailChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String rg
        {
            get
            {
                return _rg;
            }
            set
            {
                OnrgChanging(value);
                ReportPropertyChanging("rg");
                _rg = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("rg");
                OnrgChanged();
            }
        }
        private global::System.String _rg;
        partial void OnrgChanging(global::System.String value);
        partial void OnrgChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String genero
        {
            get
            {
                return _genero;
            }
            set
            {
                OngeneroChanging(value);
                ReportPropertyChanging("genero");
                _genero = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("genero");
                OngeneroChanged();
            }
        }
        private global::System.String _genero;
        partial void OngeneroChanging(global::System.String value);
        partial void OngeneroChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> dataNasc
        {
            get
            {
                return _dataNasc;
            }
            set
            {
                OndataNascChanging(value);
                ReportPropertyChanging("dataNasc");
                _dataNasc = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("dataNasc");
                OndataNascChanged();
            }
        }
        private Nullable<global::System.DateTime> _dataNasc;
        partial void OndataNascChanging(Nullable<global::System.DateTime> value);
        partial void OndataNascChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 tbCidade_id
        {
            get
            {
                return _tbCidade_id;
            }
            set
            {
                OntbCidade_idChanging(value);
                ReportPropertyChanging("tbCidade_id");
                _tbCidade_id = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("tbCidade_id");
                OntbCidade_idChanged();
            }
        }
        private global::System.Int32 _tbCidade_id;
        partial void OntbCidade_idChanging(global::System.Int32 value);
        partial void OntbCidade_idChanged();

        #endregion

    
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="TestePraticoModel", Name="tbProduto")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class tbProduto : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new tbProduto object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        public static tbProduto CreatetbProduto(global::System.Int32 id)
        {
            tbProduto tbProduto = new tbProduto();
            tbProduto.Id = id;
            return tbProduto;
        }

        #endregion

        #region Primitive Properties
    
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
                    _Id = StructuralObject.SetValidValue(value);
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
        public global::System.String Produto
        {
            get
            {
                return _Produto;
            }
            set
            {
                OnProdutoChanging(value);
                ReportPropertyChanging("Produto");
                _Produto = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Produto");
                OnProdutoChanged();
            }
        }
        private global::System.String _Produto;
        partial void OnProdutoChanging(global::System.String value);
        partial void OnProdutoChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> Fabricacao
        {
            get
            {
                return _Fabricacao;
            }
            set
            {
                OnFabricacaoChanging(value);
                ReportPropertyChanging("Fabricacao");
                _Fabricacao = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Fabricacao");
                OnFabricacaoChanged();
            }
        }
        private Nullable<global::System.DateTime> _Fabricacao;
        partial void OnFabricacaoChanging(Nullable<global::System.DateTime> value);
        partial void OnFabricacaoChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> Validade
        {
            get
            {
                return _Validade;
            }
            set
            {
                OnValidadeChanging(value);
                ReportPropertyChanging("Validade");
                _Validade = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Validade");
                OnValidadeChanged();
            }
        }
        private Nullable<global::System.DateTime> _Validade;
        partial void OnValidadeChanging(Nullable<global::System.DateTime> value);
        partial void OnValidadeChanged();

        #endregion

    
    }

    #endregion

    
}
