﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PITCSurveyApp.Helpers
{
    public interface IFileHelper
    {
		/* ATY: I believe these can all be handled in the PCL
		Task<bool> ExistsAsync(string filename);

        Task<DateTime> LastModifiedAsync(string filename);

        Task WriteTextAsync(string filename, string text);

        Task<string> ReadTextAsync(string filename);

        Task<IEnumerable<string>> GetFilesAsync();

        Task DeleteAsync(string filename);
		*/

		Task<string> GetDocsPath();
    }
}
