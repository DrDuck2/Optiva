package main;
import java.util.Scanner;
import java.util.List;
public class main {

	public static void main(String[] args) {
		SocialNetwork network;
		Scanner scanner = new Scanner(System.in);
		System.out.print("Enter site name: ");
		String siteSelection = scanner.next().toString();
		scanner.close();
		if(siteSelection.equals("Facebook")) {
			network = new Facebook("Dominik",false);
		}else if(siteSelection.equals("Twitter")) {
			network = new Twitter("Dominik", List.of("This is post","This is not post"));
		}else {
			network = new Facebook("Dominik",true);
		}
		SocialMediaAggregator aggregator = new SocialMediaAggregator(network);
		aggregator.AddPost("Some random string.");
		aggregator.DisplayPosts();
	}

}
