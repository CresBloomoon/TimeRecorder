using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeRecoder.Domain.Domain.Shared;

namespace TimeRecoder.Domain.Test.Domain.Tracking.Reports
{
    [TestFixture]
    internal class MonthlyReportBuilderTest
    {
        private MonthlyReportBuilder _MonthlyReportBuilder;

        private YmdString _Ymd0501 = new("20200501");
        private YmdString _Ymd0510 = new("20200510");
        private YmdString _Ymd0531 = new("20200531");

        private WorkProcess _Process01 = new(new Identity<WorkProcess>(1), "プロセス1");
        private WorkProcess _Process02 = new(new Identity<WorkProcess>(2), "プロセス2");
        private WorkProcess _Process03 = new(new Identity<WorkProcess>(3), "プロセス3");

        private Product _Product01 = new(new Identity<Product>(1), "製品1", "1");
        private Product _Product02 = new(new Identity<Product>(2), "製品2", "2");
        private Product _Product03 = new(new Identity<Product>(3), "製品3", "3");

        private Client _Client01 = new(new Identity<Client>(1), "田中", "タナカ");
        private Client _Client02 = new(new Identity<Client>(2), "佐藤", "サトウ");
        private Client _Client03 = new(new Identity<Client>(3), "青木", "アオキ");
    }
}
