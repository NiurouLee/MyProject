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
    unsafe class System_Threading_Tasks_TaskCompletionSource_1_SListUserComplainMessage_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(System.Threading.Tasks.TaskCompletionSource<DragonU3DSDK.Network.API.Protocol.SListUserComplainMessage>);
            args = new Type[]{typeof(DragonU3DSDK.Network.API.Protocol.SListUserComplainMessage)};
            method = type.GetMethod("SetResult", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetResult_0);
            args = new Type[]{};
            method = type.GetMethod("get_Task", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_Task_1);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* SetResult_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            DragonU3DSDK.Network.API.Protocol.SListUserComplainMessage @result = (DragonU3DSDK.Network.API.Protocol.SListUserComplainMessage)typeof(DragonU3DSDK.Network.API.Protocol.SListUserComplainMessage).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Threading.Tasks.TaskCompletionSource<DragonU3DSDK.Network.API.Protocol.SListUserComplainMessage> instance_of_this_method = (System.Threading.Tasks.TaskCompletionSource<DragonU3DSDK.Network.API.Protocol.SListUserComplainMessage>)typeof(System.Threading.Tasks.TaskCompletionSource<DragonU3DSDK.Network.API.Protocol.SListUserComplainMessage>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetResult(@result);

            return __ret;
        }

        static StackObject* get_Task_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Threading.Tasks.TaskCompletionSource<DragonU3DSDK.Network.API.Protocol.SListUserComplainMessage> instance_of_this_method = (System.Threading.Tasks.TaskCompletionSource<DragonU3DSDK.Network.API.Protocol.SListUserComplainMessage>)typeof(System.Threading.Tasks.TaskCompletionSource<DragonU3DSDK.Network.API.Protocol.SListUserComplainMessage>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Task;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new System.Threading.Tasks.TaskCompletionSource<DragonU3DSDK.Network.API.Protocol.SListUserComplainMessage>();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
