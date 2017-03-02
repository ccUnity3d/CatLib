﻿
using System;

namespace CatLib.API{

	/// <summary>
	/// 全局事件接口
	/// </summary>
	public interface IGlobalEvent{

		IGlobalEvent SetEventName(string name);

		IGlobalEvent SetInterface<T>();
		IGlobalEvent SetInterface(Type t);

		IGlobalEvent SetEventLevel(EventLevel level);

		void Trigger(EventArgs args = null);

	}

}