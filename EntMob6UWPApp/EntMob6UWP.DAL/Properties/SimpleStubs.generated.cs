using System;
using System.Runtime.CompilerServices;
using Etg.SimpleStubs;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntMob6UWP.Domain
{
    [CompilerGenerated]
    public class StubIAverage : IAverage
    {
        private readonly StubContainer<StubIAverage> _stubs = new StubContainer<StubIAverage>();

        global::System.DateTime global::EntMob6UWP.Domain.IAverage.Date
        {
            get
            {
                return _stubs.GetMethodStub<Date_Get_Delegate>("get_Date").Invoke();
            }

            set
            {
                _stubs.GetMethodStub<Date_Set_Delegate>("set_Date").Invoke(value);
            }
        }

        double global::EntMob6UWP.Domain.IAverage.Average
        {
            get
            {
                return _stubs.GetMethodStub<Average_Get_Delegate>("get_Average").Invoke();
            }
        }

        public delegate global::System.DateTime Date_Get_Delegate();

        public StubIAverage Date_Get(Date_Get_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        public delegate void Date_Set_Delegate(global::System.DateTime value);

        public StubIAverage Date_Set(Date_Set_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        public delegate double Average_Get_Delegate();

        public StubIAverage Average_Get(Average_Get_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }
    }
}