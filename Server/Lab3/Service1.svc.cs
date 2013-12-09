using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Lab3
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "Service1" в коде, SVC-файле и файле конфигурации.
    // ПРИМЕЧАНИЕ. Чтобы запустить клиент проверки WCF для тестирования службы, выберите элементы Service1.svc или Service1.svc.cs в обозревателе решений и начните отладку.
    public class Service : IService
    {
        public string To2 (int value)
        {
            return Convert.ToString(value, 2);
        }
        public string To8(int value)
        {
            return Convert.ToString(value, 8);
        }
        public string To16(int value)
        {
            return Convert.ToString(value, 16);
        }
 
    }

}
