using MappingsSquad.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MappingsSquad.Extensions
{
    public static class TopPageExtensions
    {
        public static bool IsTheSelectDataType(this TopPage topPage)
        {
            return topPage == TopPage.SelectDataType;
        }

        public static bool IsTheFileUpload(this TopPage topPage)
        {
            return topPage == TopPage.FileUpload;
        }

        public static bool IsTheMapping(this TopPage topPage)
        {
            return topPage == TopPage.Mapping;
        }

        public static bool IsTheImport(this TopPage topPage)
        {
            return topPage == TopPage.Import;
        }

        public static bool IsTheNextPageOf(this TopPage topPage, TopPage page)
        {
            return (int)topPage - (int)page == 1;
        }

        public static bool IsThePreviousPageOf(this TopPage currentPage, TopPage topPage)
        {
            return (int)topPage - (int)currentPage > 0;
        }
    }
}
