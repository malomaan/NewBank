using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using log4net;

namespace NewBankWEB
{
    public class LogUtilidad
    {
        public void Registrar_Log(string sistema, string sms, string tipo)
        {
            string v_tipo = tipo.ToUpper();
            ILog logger = LogManager.GetLogger("NewBak");
            switch (tipo)
            {
                case "DEBUG":
                    logger.Debug(sms);
                    break;
                case "INFO":
                    logger.Info(sms);
                    break;
                case "WARN":
                    logger.Warn(sms);
                    break;
                case "ERROR":
                    logger.Error(sms);
                    break;
                case "FATAL":
                    logger.Fatal(sms);
                    break;
                default:
                    logger.Info(sms);
                    break;
            }
        }
    }
}