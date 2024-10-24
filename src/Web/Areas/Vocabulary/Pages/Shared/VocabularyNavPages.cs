using Microsoft.AspNetCore.Mvc.Rendering;

namespace Web.Areas.Vocabulary.Pages.Shared
{
    public static class VocabularyNavPages
    {
        public static string Adjectives => "Adjectives";

        public static string? AdjectivesNavClass(ViewContext viewContext) => PageNavClass(viewContext, Adjectives);

        public static string? PageNavClass(ViewContext viewContext, string page)
        {
            var activePage = viewContext.ViewData["ActivePage"] as string ?? Path.GetFileNameWithoutExtension(viewContext.ActionDescriptor.DisplayName);
            return string.Equals(activePage, page, StringComparison.OrdinalIgnoreCase) ? "active" : null;
        }
    }
}