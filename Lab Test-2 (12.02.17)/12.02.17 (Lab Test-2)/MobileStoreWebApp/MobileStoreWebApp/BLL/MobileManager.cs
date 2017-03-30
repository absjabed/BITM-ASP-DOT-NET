using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MobileStoreWebApp.Getway;
using MobileStoreWebApp.Model;

namespace MobileStoreWebApp.BLL
{
    public class MobileManager
    {

        MobileGatway mobileGatway = new MobileGatway();

        public bool IsExists(string imei)
        {
           bool tag = mobileGatway.IsExists(imei);
            return tag;
        }

        public int SaveMobile(MobilePhone aMobilePhone)
        {
            int row = mobileGatway.SaveMobile(aMobilePhone);
            return row;
        }

        public List<MobilePhone> SearchMobilePrice(decimal startingPrice, decimal endingPrice)
        {
            return mobileGatway.SearchMobilePrice(startingPrice, endingPrice);
        }

        public List<MobilePhone> GetMobiles()
        {
            return mobileGatway.GetMobiles();
        }

        public MobilePhone getByImei(string imei)
        {
            return mobileGatway.getByImei(imei);
        }
    }
}