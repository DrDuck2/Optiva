package main;

import java.util.List;

public class Twitter extends SocialNetwork {
private String user;
private List<String> alwaysTag;

public Twitter(String user, List<String> alwaysTag) {
	this.user = user;
	this.alwaysTag = alwaysTag;
}
	
@Override
public IPostable CreatePost(String content) {
	return new TwitterPost(content,alwaysTag);
}
}
