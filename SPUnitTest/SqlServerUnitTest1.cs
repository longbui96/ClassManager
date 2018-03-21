using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;
using Microsoft.Data.Tools.Schema.Sql.UnitTesting;
using Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SPUnitTest
{
    [TestClass()]
    public class SqlServerUnitTest1 : SqlDatabaseTestClass
    {

        public SqlServerUnitTest1()
        {
            InitializeComponent();
        }

        [TestInitialize()]
        public void TestInitialize()
        {
            base.InitializeTest();
        }
        [TestCleanup()]
        public void TestCleanup()
        {
            base.CleanupTest();
        }

        #region Designer support code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_INS_MUONTest_TestAction;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SqlServerUnitTest1));
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_INS_TKBTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_QLPHRoomUpdateTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_QLPHTKBUpdateTest_TestAction;
            this.dbo_INS_MUONTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.dbo_INS_TKBTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.dbo_QLPHRoomUpdateTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.dbo_QLPHTKBUpdateTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            dbo_INS_MUONTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            dbo_INS_TKBTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            dbo_QLPHRoomUpdateTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            dbo_QLPHTKBUpdateTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            // 
            // dbo_INS_MUONTest_TestAction
            // 
            resources.ApplyResources(dbo_INS_MUONTest_TestAction, "dbo_INS_MUONTest_TestAction");
            // 
            // dbo_INS_TKBTest_TestAction
            // 
            resources.ApplyResources(dbo_INS_TKBTest_TestAction, "dbo_INS_TKBTest_TestAction");
            // 
            // dbo_QLPHRoomUpdateTest_TestAction
            // 
            resources.ApplyResources(dbo_QLPHRoomUpdateTest_TestAction, "dbo_QLPHRoomUpdateTest_TestAction");
            // 
            // dbo_QLPHTKBUpdateTest_TestAction
            // 
            resources.ApplyResources(dbo_QLPHTKBUpdateTest_TestAction, "dbo_QLPHTKBUpdateTest_TestAction");
            // 
            // dbo_INS_MUONTestData
            // 
            this.dbo_INS_MUONTestData.PosttestAction = null;
            this.dbo_INS_MUONTestData.PretestAction = null;
            this.dbo_INS_MUONTestData.TestAction = dbo_INS_MUONTest_TestAction;
            // 
            // dbo_INS_TKBTestData
            // 
            this.dbo_INS_TKBTestData.PosttestAction = null;
            this.dbo_INS_TKBTestData.PretestAction = null;
            this.dbo_INS_TKBTestData.TestAction = dbo_INS_TKBTest_TestAction;
            // 
            // dbo_QLPHRoomUpdateTestData
            // 
            this.dbo_QLPHRoomUpdateTestData.PosttestAction = null;
            this.dbo_QLPHRoomUpdateTestData.PretestAction = null;
            this.dbo_QLPHRoomUpdateTestData.TestAction = dbo_QLPHRoomUpdateTest_TestAction;
            // 
            // dbo_QLPHTKBUpdateTestData
            // 
            this.dbo_QLPHTKBUpdateTestData.PosttestAction = null;
            this.dbo_QLPHTKBUpdateTestData.PretestAction = null;
            this.dbo_QLPHTKBUpdateTestData.TestAction = dbo_QLPHTKBUpdateTest_TestAction;
        }

        #endregion


        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        #endregion

        [TestMethod()]
        public void dbo_INS_MUONTest()
        {
            SqlDatabaseTestActions testActions = this.dbo_INS_MUONTestData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }

        [TestMethod()]
        public void dbo_INS_TKBTest()
        {
            SqlDatabaseTestActions testActions = this.dbo_INS_TKBTestData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }

        [TestMethod()]
        public void dbo_QLPHRoomUpdateTest()
        {
            SqlDatabaseTestActions testActions = this.dbo_QLPHRoomUpdateTestData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }

        [TestMethod()]
        public void dbo_QLPHTKBUpdateTest()
        {
            SqlDatabaseTestActions testActions = this.dbo_QLPHTKBUpdateTestData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }
        private SqlDatabaseTestActions dbo_INS_MUONTestData;
        private SqlDatabaseTestActions dbo_INS_TKBTestData;
        private SqlDatabaseTestActions dbo_QLPHRoomUpdateTestData;
        private SqlDatabaseTestActions dbo_QLPHTKBUpdateTestData;
    }
}
