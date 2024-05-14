using System;

public class Journal
{
    private List<string> prompts = new List<string>();
    private List<string> responses = new List<string>();

    public void AddEntry(string prompt, string response)
    {
        prompts.Add(prompt);
        responses.Add(response);
    }

    public int EntryCount()
    {
        return prompts.Count;
    }

    public string GetPrompt(int index)
    {
        return prompts[index];
    }

    public string GetResponse(int index)
    {
        return responses[index];
    }

}