var pt = (X: 1, Y: 2);

var slope = (double)pt.Y / pt.X;
Console.WriteLine($"A line from the origin to the point: {pt} has a slope od {slope}.");

pt.X = pt.Y = 5;

Console.WriteLine($"The point is now at {pt}.");
