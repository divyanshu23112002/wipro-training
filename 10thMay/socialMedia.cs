//Social Media

using System;
public class SocialMedia
{
    public virtual void Post()
    {
        Console.WriteLine("Posting on Social Media");
} 
}
public class FbPost:SocialMedia
{
    public override void Post()
    {
        Console.WriteLine("Posting on FaceBook");
    }
}
public class TwitterPost:SocialMedia
{
    public override void Post()
    {
        Console.WriteLine("Tweeting on Twitter");
    }


}
public class InstaPost:SocialMedia
{
    public override void Post()
    {
        Console.WriteLine("Posting on Instagram");
    }
}
public class Program
{
    public static void Main()
    {
        FbPost fb=new FbPost();
        TwitterPost twitter=new TwitterPost();
        InstaPost insta=new InstaPost();

        fb.Post();
        twitter.Post(); 
        insta.Post();

        Console.WriteLine("\nUsing Polymorphism: ");

        SocialMedia post;

        post = new FbPost();
        post.Post();

        post = new TwitterPost();
        post.Post();

        post = new InstaPost();
        post.Post();

    }
}