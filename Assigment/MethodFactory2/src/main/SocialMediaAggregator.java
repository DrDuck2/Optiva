package main;

import java.util.List;
import java.util.ArrayList;

public class SocialMediaAggregator {
SocialNetwork socialNetwork;
List<IPostable> posts;

public SocialMediaAggregator(SocialNetwork network) {
	this.posts = new ArrayList<>();
	this.socialNetwork = network;
}

public void DisplayPosts() {
	for(IPostable post : posts) {
		System.out.println(post.DisplayPost());
	}
}

public void AddPost(String content) {
	this.posts.add(this.socialNetwork.CreatePost(content));
}
}
