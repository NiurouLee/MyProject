// **********************************************
// Copyright(c) 2021 by com.ustar
// All right reserved
// 
// Author : Jian.Wang
// Date :2021-05-20 3:52 PM
// Ver : 1.0.0
// Description : LocalStorableInt.cs
// 本地可存储的Int变量
// 方便玩家某些状态的存储和使用，让代码逻辑更加简洁
// 实现变量自动更新，自动加载
// ChangeLog :
// **********************************************

namespace GameModule
{
    public class LocalStorableInt 
    {
        private int value;
        private string storeName;
        private int defaultValue;

        public LocalStorableInt(string inStoreName, int inDefaultValue)
        {
            storeName = inStoreName;
            
            // if (Client.Player.IsValid())
            // {
            //     storeName = Client.Player.Id + "_" + storeName;
            // }
            
            defaultValue = inDefaultValue;
           
            LoadValue();
        }

        public int Value
        {
            get => value;
            set
            {
                this.value = value;
                Client.Storage.SetItem(storeName, value);
            }
        }
        public void LoadValue()
        {
            value = Client.Storage.GetItem(storeName, defaultValue);
        }
        
        public static implicit operator int (LocalStorableInt m1)
        {
            return m1.value;
        }

        public void ResetValue()
        {
            value = defaultValue;
            Client.Storage.DeleteItem(storeName);
        }
    }
}