package main;

public class Facebook extends SocialNetwork {
private String user;
private boolean privateProfile;

public Facebook(String username,boolean privateProfile) {
	this.user = username;
	this.privateProfile = privateProfile;
}

@Override
public IPostable CreatePost(String content) {
	return new FacebookPost(content,privateProfile);
}
}
