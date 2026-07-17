using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> _prompts = new List<string>
    {
        "What was the best part of your day?",
        "What are you grateful for today?",
        "Describe a challenge you faced and how you overcame it.",
        "What you are doing to achieve the goal for this week?",
        "What is something new you learned today?",
        "Describe a person who has had a positive impact on your life.",
        "Reflect on a accomplishment from today and how it made you feel.",
        "Write about a place you visited today and why."
    };

    private Random _random = new Random();
    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }
}