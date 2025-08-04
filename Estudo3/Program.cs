string greeting = "    Hello World!";
Console.WriteLine($"[{greeting}]");

string trimmedGreeting = greeting.Trim();
Console.WriteLine($"[{trimmedGreeting}]");

trimmedGreeting = trimmedGreeting.TrimEnd();
Console.WriteLine($"[{trimmedGreeting}]");

trimmedGreeting = trimmedGreeting.Trim();
Console.WriteLine($"[{trimmedGreeting}]");