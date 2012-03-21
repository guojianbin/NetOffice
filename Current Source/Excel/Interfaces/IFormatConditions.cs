//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Reflection;
using System.Collections.Generic;
using System.Collections;
using LateBindingApi.Core;
namespace NetOffice.ExcelApi
{
	///<summary>
	/// Interface IFormatConditions 
	/// SupportByVersion Excel, 9,10,11,12,14
	///</summary>
	[SupportByVersionAttribute("Excel", 9,10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsInterface)]
	public class IFormatConditions : COMObject ,IEnumerable<NetOffice.ExcelApi.FormatCondition>
	{
		#pragma warning disable
		#region Type Information

        private static Type _type;

		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(IFormatConditions);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IFormatConditions(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IFormatConditions(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IFormatConditions(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IFormatConditions() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IFormatConditions(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14)]
		public NetOffice.ExcelApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.ExcelApi.Application newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.Application.LateBindingApiWrapperType) as NetOffice.ExcelApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14)]
		public NetOffice.ExcelApi.Enums.XlCreator Creator
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Creator", paramsArray);
				return (NetOffice.ExcelApi.Enums.XlCreator)returnItem;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14)]
		public COMObject Parent
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Parent", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14)]
		public Int32 Count
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Count", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		/// <param name="index">object Index</param>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public NetOffice.ExcelApi.FormatCondition this[object index]
		{
			get
{			
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.PropertyGet(this, "_Default", paramsArray);
			NetOffice.ExcelApi.FormatCondition newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.FormatCondition.LateBindingApiWrapperType) as NetOffice.ExcelApi.FormatCondition;
			return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="type">NetOffice.ExcelApi.Enums.XlFormatConditionType Type</param>
		/// <param name="_operator">optional object Operator</param>
		/// <param name="formula1">optional object Formula1</param>
		/// <param name="formula2">optional object Formula2</param>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14)]
		public NetOffice.ExcelApi.FormatCondition Add(NetOffice.ExcelApi.Enums.XlFormatConditionType type, object _operator, object formula1, object formula2)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(type, _operator, formula1, formula2);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.ExcelApi.FormatCondition newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.FormatCondition.LateBindingApiWrapperType) as NetOffice.ExcelApi.FormatCondition;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14
		/// </summary>
		/// <param name="type">NetOffice.ExcelApi.Enums.XlFormatConditionType Type</param>
		/// <param name="_operator">optional object Operator</param>
		/// <param name="formula1">optional object Formula1</param>
		/// <param name="formula2">optional object Formula2</param>
		/// <param name="_string">optional object String</param>
		/// <param name="textOperator">optional object TextOperator</param>
		/// <param name="dateOperator">optional object DateOperator</param>
		/// <param name="scopeType">optional object ScopeType</param>
		[SupportByVersionAttribute("Excel", 12,14)]
		public COMObject Add(NetOffice.ExcelApi.Enums.XlFormatConditionType type, object _operator, object formula1, object formula2, object _string, object textOperator, object dateOperator, object scopeType)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(type, _operator, formula1, formula2, _string, textOperator, dateOperator, scopeType);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="type">NetOffice.ExcelApi.Enums.XlFormatConditionType Type</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 9,10,11,12,14)]
		public NetOffice.ExcelApi.FormatCondition Add(NetOffice.ExcelApi.Enums.XlFormatConditionType type)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(type);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.ExcelApi.FormatCondition newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.FormatCondition.LateBindingApiWrapperType) as NetOffice.ExcelApi.FormatCondition;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="type">NetOffice.ExcelApi.Enums.XlFormatConditionType Type</param>
		/// <param name="_operator">optional object Operator</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 9,10,11,12,14)]
		public NetOffice.ExcelApi.FormatCondition Add(NetOffice.ExcelApi.Enums.XlFormatConditionType type, object _operator)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(type, _operator);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.ExcelApi.FormatCondition newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.FormatCondition.LateBindingApiWrapperType) as NetOffice.ExcelApi.FormatCondition;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="type">NetOffice.ExcelApi.Enums.XlFormatConditionType Type</param>
		/// <param name="_operator">optional object Operator</param>
		/// <param name="formula1">optional object Formula1</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 9,10,11,12,14)]
		public NetOffice.ExcelApi.FormatCondition Add(NetOffice.ExcelApi.Enums.XlFormatConditionType type, object _operator, object formula1)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(type, _operator, formula1);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.ExcelApi.FormatCondition newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.FormatCondition.LateBindingApiWrapperType) as NetOffice.ExcelApi.FormatCondition;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14
		/// </summary>
		/// <param name="type">NetOffice.ExcelApi.Enums.XlFormatConditionType Type</param>
		/// <param name="_operator">optional object Operator</param>
		/// <param name="formula1">optional object Formula1</param>
		/// <param name="formula2">optional object Formula2</param>
		/// <param name="_string">optional object String</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 12,14)]
		public COMObject Add(NetOffice.ExcelApi.Enums.XlFormatConditionType type, object _operator, object formula1, object formula2, object _string)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(type, _operator, formula1, formula2, _string);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14
		/// </summary>
		/// <param name="type">NetOffice.ExcelApi.Enums.XlFormatConditionType Type</param>
		/// <param name="_operator">optional object Operator</param>
		/// <param name="formula1">optional object Formula1</param>
		/// <param name="formula2">optional object Formula2</param>
		/// <param name="_string">optional object String</param>
		/// <param name="textOperator">optional object TextOperator</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 12,14)]
		public COMObject Add(NetOffice.ExcelApi.Enums.XlFormatConditionType type, object _operator, object formula1, object formula2, object _string, object textOperator)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(type, _operator, formula1, formula2, _string, textOperator);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14
		/// </summary>
		/// <param name="type">NetOffice.ExcelApi.Enums.XlFormatConditionType Type</param>
		/// <param name="_operator">optional object Operator</param>
		/// <param name="formula1">optional object Formula1</param>
		/// <param name="formula2">optional object Formula2</param>
		/// <param name="_string">optional object String</param>
		/// <param name="textOperator">optional object TextOperator</param>
		/// <param name="dateOperator">optional object DateOperator</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Excel", 12,14)]
		public COMObject Add(NetOffice.ExcelApi.Enums.XlFormatConditionType type, object _operator, object formula1, object formula2, object _string, object textOperator, object dateOperator)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(type, _operator, formula1, formula2, _string, textOperator, dateOperator);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14)]
		public Int32 Delete()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "Delete", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14
		/// </summary>
		/// <param name="colorScaleType">Int32 ColorScaleType</param>
		[SupportByVersionAttribute("Excel", 12,14)]
		public COMObject AddColorScale(Int32 colorScaleType)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(colorScaleType);
			object returnItem = Invoker.MethodReturn(this, "AddColorScale", paramsArray);
			COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14
		/// </summary>
		[SupportByVersionAttribute("Excel", 12,14)]
		public COMObject AddDatabar()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "AddDatabar", paramsArray);
			COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14
		/// </summary>
		[SupportByVersionAttribute("Excel", 12,14)]
		public COMObject AddIconSetCondition()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "AddIconSetCondition", paramsArray);
			COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14
		/// </summary>
		[SupportByVersionAttribute("Excel", 12,14)]
		public COMObject AddTop10()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "AddTop10", paramsArray);
			COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14
		/// </summary>
		[SupportByVersionAttribute("Excel", 12,14)]
		public COMObject AddAboveAverage()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "AddAboveAverage", paramsArray);
			COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14
		/// </summary>
		[SupportByVersionAttribute("Excel", 12,14)]
		public COMObject AddUniqueValues()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "AddUniqueValues", paramsArray);
			COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
			return newObject;
		}

		#endregion

       #region IEnumerable<NetOffice.ExcelApi.FormatCondition> Member
        
        /// <summary>
		/// SupportByVersionAttribute Excel, 9,10,11,12,14
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14)]
       public IEnumerator<NetOffice.ExcelApi.FormatCondition> GetEnumerator()  
       {
           NetRuntimeSystem.Collections.IEnumerable innerEnumerator = (this as NetRuntimeSystem.Collections.IEnumerable);
           foreach (NetOffice.ExcelApi.FormatCondition item in innerEnumerator)
               yield return item;
       }

       #endregion
          
		#region IEnumerable Members
       
		/// <summary>
		/// SupportByVersionAttribute Excel, 9,10,11,12,14
		/// </summary>
		[SupportByVersionAttribute("Excel", 9,10,11,12,14)]
		IEnumerator NetRuntimeSystem.Collections.IEnumerable.GetEnumerator()
		{
			return LateBindingApi.Core.Utils.GetProxyEnumeratorAsProperty(this);
		}

		#endregion
		#pragma warning restore
	}
}