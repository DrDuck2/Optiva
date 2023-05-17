package main;

import java.time.LocalDateTime;
import java.time.format.DateTimeFormatter;

public class FacebookPost implements IPostable {
private LocalDateTime timestamp;
private String content;
private boolean isPrivate;

public FacebookPost(String content, boolean isPrivate) {
	this.content = content;
	this.isPrivate = isPrivate;
	this.timestamp = LocalDateTime.now();
}

public LocalDateTime getTimestamp() {
	return this.timestamp;
}
public String getContent() {
	return this.content;
}

public String DisplayPost() {
	return GenerateHeader() + GenerateContent();
}

private String GenerateHeader() {
	return "@" + this.timestamp.format(DateTimeFormatter.ofPattern("hh:mm a"))+": ";
}
private String GenerateContent() {
	return this.isPrivate ? "Hidden!" : this.content;
}
}
