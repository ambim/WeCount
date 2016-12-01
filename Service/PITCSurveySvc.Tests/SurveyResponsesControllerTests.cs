﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using PITCSurveySvc.Entities;

namespace PITCSurveySvc.Tests
{
	[TestClass]
	public class SurveyResponsesControllerTests
	{
		private PITCSurveyContext _db;

		[TestInitialize]
		public void Init()
		{
			EffortProviderFactory.ResetDB();
		}

		public SurveyResponsesControllerTests()
		{
			//DbConnection conn = DbConnectionFactory.CreateTransient();
			//_db = new WeCountContext(conn);
			_db = new PITCSurveyContext();
		}

		[TestMethod]
		public void PostSurveyResponse()
		{
			using (var db = new PITCSurveyContext("WeCountContext"))
			{
				//
			}

		}
	}
}
