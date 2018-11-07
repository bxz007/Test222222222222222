using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameMain;
using GameFramework.DataTable;

public class UserData : EntityData {

    [SerializeField]
    private string myDescription;


    private string assetName;

    public UserData(int entityId, int typeId)
         : base(entityId, typeId)
    {
        IDataTable<DRUser> dtEffect = GameEntry.DataTable.GetDataTable<DRUser>();
        DRUser dr = dtEffect.GetDataRow(typeId);      
        MyDescription = dr.Description;
    }

    public string MyDescription
    {
        get
        {
            return myDescription;
        }

        set
        {
            myDescription = value;
        }
    }

    public string AssetName
    {
        get
        {
            return assetName;
        }

        set
        {
            assetName = value;
        }
    }
}
