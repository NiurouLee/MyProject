using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

using ILRuntime.CLR.TypeSystem;
using ILRuntime.CLR.Method;
using ILRuntime.Runtime.Enviorment;
using ILRuntime.Runtime.Intepreter;
using ILRuntime.Runtime.Stack;
using ILRuntime.Reflection;
using ILRuntime.CLR.Utils;

namespace ILRuntime.Runtime.Generated
{
    unsafe class System_Tuple_3_Action_1_IMessage_IMessage_String_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(System.Tuple<System.Action<Google.ilruntime.Protobuf.IMessage>, Google.ilruntime.Protobuf.IMessage, System.String>);
            args = new Type[]{};
            method = type.GetMethod("get_Item1", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_Item1_0);
            args = new Type[]{};
            method = type.GetMethod("get_Item2", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_Item2_1);
            args = new Type[]{};
            method = type.GetMethod("get_Item3", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_Item3_2);

            args = new Type[]{typeof(System.Action<Google.ilruntime.Protobuf.IMessage>), typeof(Google.ilruntime.Protobuf.IMessage), typeof(System.String)};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_Item1_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Tuple<System.Action<Google.ilruntime.Protobuf.IMessage>, Google.ilruntime.Protobuf.IMessage, System.String> instance_of_this_method = (System.Tuple<System.Action<Google.ilruntime.Protobuf.IMessage>, Google.ilruntime.Protobuf.IMessage, System.String>)typeof(System.Tuple<System.Action<Google.ilruntime.Protobuf.IMessage>, Google.ilruntime.Protobuf.IMessage, System.String>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Item1;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_Item2_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Tuple<System.Action<Google.ilruntime.Protobuf.IMessage>, Google.ilruntime.Protobuf.IMessage, System.String> instance_of_this_method = (System.Tuple<System.Action<Google.ilruntime.Protobuf.IMessage>, Google.ilruntime.Protobuf.IMessage, System.String>)typeof(System.Tuple<System.Action<Google.ilruntime.Protobuf.IMessage>, Google.ilruntime.Protobuf.IMessage, System.String>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Item2;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_Item3_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Tuple<System.Action<Google.ilruntime.Protobuf.IMessage>, Google.ilruntime.Protobuf.IMessage, System.String> instance_of_this_method = (System.Tuple<System.Action<Google.ilruntime.Protobuf.IMessage>, Google.ilruntime.Protobuf.IMessage, System.String>)typeof(System.Tuple<System.Action<Google.ilruntime.Protobuf.IMessage>, Google.ilruntime.Protobuf.IMessage, System.String>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Item3;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @item3 = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Google.ilruntime.Protobuf.IMessage @item2 = (Google.ilruntime.Protobuf.IMessage)typeof(Google.ilruntime.Protobuf.IMessage).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Action<Google.ilruntime.Protobuf.IMessage> @item1 = (System.Action<Google.ilruntime.Protobuf.IMessage>)typeof(System.Action<Google.ilruntime.Protobuf.IMessage>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = new System.Tuple<System.Action<Google.ilruntime.Protobuf.IMessage>, Google.ilruntime.Protobuf.IMessage, System.String>(@item1, @item2, @item3);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
