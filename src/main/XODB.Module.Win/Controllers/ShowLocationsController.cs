﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo;
using DevExpress.ExpressApp.DC;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Reflection;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.Persistent.Base;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using XODB.Module.BusinessObjects;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.Persistent.Base;
using DevExpress.ExpressApp.SystemModule;
//using DevExpress.Persistent.BaseImpl;
namespace XODB.Module.Win.Controllers
{

    public partial class ShowLocationsController : ViewController {

        public ShowLocationsController() {
            PopupWindowShowAction showLocationsAction = new PopupWindowShowAction(this, "Show Locations", "View");
            showLocationsAction.ImageName = "Action_NavigationBar";
            showLocationsAction.CustomizePopupWindowParams += new CustomizePopupWindowParamsEventHandler(showLocationsAction_CustomizePopupWindowParams);
            TargetViewType = ViewType.ListView;
            TargetObjectType = typeof(object);
        }


        void showLocationsAction_CustomizePopupWindowParams(object sender, CustomizePopupWindowParamsEventArgs e) {

            try
            {
                IObjectSpace objectSpace = Application.CreateObjectSpace();

                var o = (System.Data.Objects.DataClasses.EntityObject)e.Action.SelectionContext.CurrentObject;
                var c = ((DevExpress.ExpressApp.EF.EFObjectSpace)objectSpace).ObjectContext;
                var table = XODB.Module.BusinessObjects.BusinessObjectHelper.GetTableName(c, e.Action.SelectionContext.CurrentObject.GetType());
                var value = (Guid)o.EntityKey.EntityKeyValues[0].Value;

                
                CollectionSource collectionSource = new CollectionSource(objectSpace, typeof(LocationData));
                CriteriaOperator c1 = new BinaryOperator(
                    new OperandProperty("TableType"), table,
                    BinaryOperatorType.Equal
                );
                CriteriaOperator c2 = new BinaryOperator(
                    new OperandProperty("ReferenceID"), value,
                    BinaryOperatorType.Equal
                );
                CriteriaOperator co = c1 & c2;
                collectionSource.Criteria.Add("Refences", co);
                //Do this for manual data lists
                //if ((collectionSource.Collection as XPBaseCollection) != null)
                //{
                //    ((XPBaseCollection)collectionSource.Collection).LoadingEnabled = false;
                //}
                ListView view = Application.CreateListView(Application.GetListViewId(typeof(LocationData)), collectionSource, false);
                view.Editor.AllowEdit = true;
                foreach (var k in view.AllowNew.GetKeys())
                    view.AllowNew[k] = false;
                foreach (var k in view.AllowDelete.GetKeys())
                    view.AllowDelete[k] = false;
                foreach (var k in view.AllowEdit.GetKeys())
                    view.AllowEdit[k] = false;
                foreach (var k in e.DialogController.AcceptAction.Enabled.GetKeys())
                    e.DialogController.AcceptAction.Enabled[k] = false;
                e.DialogController.AcceptAction.Enabled.SetItemValue("Item.Enabled", false);
                e.View = view;
                e.DialogController.SaveOnAccept = false;
                
            }
            catch (Exception ex)
            { }


        }
    }
   
}