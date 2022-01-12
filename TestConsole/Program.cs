#define Shapes
#define EmployeePay
#define Debugging
#define StudentCollection
#define StateCollection
#define Sales
#define Purchasing
#define EDI
#define ETL
//-----------< Comment the #undef for the project you are testing >-----------//
#undef Shapes
#undef EmployeePay
#undef Debugging
#undef StudentCollection
#undef StateCollection
#undef Sales
#undef Purchasing
#undef EDI
#undef ETL

using static System.Console;
#if Shapes
using Shapes;
#endif
#if Debugging
using Debugging;
#endif
#if EmployeePay
using EmployeePay;
#endif
#if Purchasing
using Purchasing;
#endif


namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("<----- Student: YOUR NAME GOES HERE ----->");
#region Shapes
#if Shapes
            Shapes.TestShapes.Test();
#endif
#endregion
#region Employee Pay
#if EmployeePay
            EmployeePay.EmployeeTest.Test();
#endif
#endregion
#region Debugging
#if Debugging
            Debugging.Debugging.Test();
#endif
#endregion
#region Student Collection
#if StudentCollection
            Collection.TestStudentCollection.TestStudentCollections();
#endif
#endregion
#region State Collection
#if StateCollection
            StateCollection.TestStateCollection.Test();
#endif
#endregion
#region Sales
#if Sales
            Sales.SalesTest.Test();
#endif
#endregion
#region Purchasing
#if Purchasing
            Purchasing.PurchasingTest.Test();
#endif
#endregion
#region EDI
#if EDI
            EDI.TestEDI.Test();
#endif
#endregion
#region ETL
#if ETL
            ETL.TestEtl.Test();
#endif
#endregion
            ReadKey();
        }
    }
}
