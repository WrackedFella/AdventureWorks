using System;

namespace AdventureWorks.Domain
{
	public abstract class EntityBase
	{
		public string ModifiedBy { get; set; }
		public DateTime ModifiedDate { get; set; }

		internal void SetAuditDetails(string username)
		{
			this.ModifiedBy = username;
			this.ModifiedDate = DateTime.Now;
		}

		//public T GetId<T>()
		//{
		//	var keyProp = this.GetType().GetProperties().FirstOrDefault(p => p.CustomAttributes.Any(a => a.AttributeType == typeof(KeyAttribute)));
		//	if(keyProp == null)
		//	{
		//		throw new NullReferenceException();
		//	}
		//	return (T)keyProp.GetValue(this);
		//}
		//public (T1, T2) GetId<T1, T2>()
		//{
		//	var keyProps = this.GetType().GetProperties().Where(p => p.CustomAttributes.Any(a => a.AttributeType == typeof(KeyAttribute))).ToArray();
		//	if (keyProps.Length != 2)
		//	{
		//		throw new NullReferenceException();
		//	}
		//	return ((T1)keyProps[0].GetValue(this), (T2)keyProps[1].GetValue(this));
		//}
		//public (T1, T2, T3) GetId<T1, T2, T3>()
		//{
		//	var keyProps = this.GetType().GetProperties().Where(p => p.CustomAttributes.Any(a => a.AttributeType == typeof(KeyAttribute))).ToArray();
		//	if (keyProps.Length != 3)
		//	{
		//		throw new NullReferenceException();
		//	}
		//	return ((T1)keyProps[0].GetValue(this), (T2)keyProps[1].GetValue(this), (T3)keyProps[2].GetValue(this));
		//}
		//public (T1, T2, T3, T4) GetId<T1, T2, T3, T4>()
		//{
		//	var keyProps = this.GetType().GetProperties().Where(p => p.CustomAttributes.Any(a => a.AttributeType == typeof(KeyAttribute))).ToArray();
		//	if (keyProps.Length != 4)
		//	{
		//		throw new NullReferenceException();
		//	}
		//	return ((T1)keyProps[0].GetValue(this), (T2)keyProps[1].GetValue(this), (T3)keyProps[2].GetValue(this), (T4)keyProps[3].GetValue(this));
		//}
	}
}
