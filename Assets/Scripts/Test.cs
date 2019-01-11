using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts
{
    class Test
    {
        public enum HomeState
        {
            Upgrading,//升级中
            Normal,//常态
        }
        public enum MsgStateType
        {
            Normal = 0,
            Creating = 1,
            Upgrading = 2,
            CreateFinish = 3,
            UpgradeFinish = 4,
            OfflineFinish = 5,
        }
        public enum BuildingStateType
        {
            BuildingLeisure = 0,  //建筑空闲
            Default = 1,         //默认
            BuildingOccupy = 2,  //建筑占有
        }

        public enum UpgradeState
        {
            BuildUpgrade,//建筑升级
            HomeUpgrade,//家园升级
        }

        public enum BuildingState
        {
            FirstBuild,//第一次建造
            Building,//建造中
            Upgrade,//升级
        }

        public enum BuildHeadUIType
        {
            Normal = 0,//正常状态
            Build = 1, //建造耗时
            Upgrade = 2,  //升级耗时
            UpgradeOverEffect = 3,  //升级完成特效
            Tip = 4, //tip信息
            Destory = 5, //删除
            Create = 6,//创建
        }

        public enum ConfirmWindowType
        {
            NewBuild = 0,//新建建筑
            DestoryBuild = 1 //删除建筑
        }
        public enum NotifyType
        {
            IM,//聊天窗消息
            Toast,//Toast消息
        }

        public enum AreaMapType
        {
            HOMELAND_OWNER,//自己家园
            HOMELAND_OTHER,//别人家园
        }

    }
}
