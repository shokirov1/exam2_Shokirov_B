using Project1;

var math = new Project1.Mathh();

Console.WriteLine("Result double: " + math.Abs(-3.14));
Console.WriteLine("Result float: " + math.Abs(-3.14));
Console.WriteLine("Result int: " + math.Abs(-3));
Console.WriteLine("Result Pow: "+math.Pow(2,2));
Console.WriteLine("Result Sqrt: " + math.Sqrt(10));
Console.WriteLine("Result Max: " + math.Max(10,8));
Console.WriteLine("Result Min: " + math.Min(10,8));

var post1 =new Post();
var post2 = new Post();
var post3 = new Post();
var post4 = new Post();
var post5 = new Post();

post1.Title = "Test1";
post2.Title = "Test2";
post3.Title = "Test3";
post4.Title = "Test4";
post5.Title = "Test5";

post1.Description = "Description1";
post2.Description = "Description2";
post3.Description = "Description3";
post4.Description = "Description4";
post5.Description = "Description5";

post1.LikeCount = 1;
post2.LikeCount = 2;
post3.LikeCount = 3;
post4.LikeCount = 4;
post5.LikeCount = 5;

post1.Comments = new  []{"Comment1", "Comment2", "Comment3", "Comment4", "Comment5" };

Console.WriteLine($" {post1.Title} – {post1.Description} – number of Likes: {post1.LikeCount} {post1.Comments[0]}");
Console.WriteLine($" {post2.Title} – {post2.Description} – number of Likes: {post2.LikeCount} {post1.Comments[1]}");
Console.WriteLine($" {post3.Title} – {post3.Description} – number of Likes: {post3.LikeCount} {post1.Comments[2]}");
Console.WriteLine($" {post4.Title} – {post4.Description} – number of Likes: {post4.LikeCount} {post1.Comments[3]}");
Console.WriteLine($" {post5.Title} – {post5.Description} – number of Likes: {post5.LikeCount} {post1.Comments[4]}");










