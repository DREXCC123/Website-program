using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class IndexModel : PageModel
{
    [BindProperty]
    public string InputString { get; set; }

    public int WordCount { get; private set; }

    public void OnGet()
    {
    }

    public IActionResult OnPost()
    {
        WordCount = CountWords(InputString);
        return Page();
    }

    private int CountWords(string str)
    {
        if (string.IsNullOrWhiteSpace(str))
            return 0;

        int l = 0;
        int wrd = 1;

        while (l <= str.Length - 1)
        {
            if (str[l] == ' ' || str[l] == '\n' || str[l] == '\t')
            {
                wrd++;
            }

            l++;
        }

        return wrd;
    }
}