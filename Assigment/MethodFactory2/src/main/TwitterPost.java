package main;
import java.time.LocalDateTime;
import java.time.format.DateTimeFormatter;
import java.util.List;

public class TwitterPost implements IPostable{
List<String> alwaysTag;
private LocalDateTime timestamp;
private String content;

public TwitterPost(String content, List<String> alwaysTag) {
	this.content = content;
	this.alwaysTag = alwaysTag;
	this.timestamp = LocalDateTime.now();
}

public String Content() {
	return this.content;
}
public LocalDateTime getTimestamp() {
	return this.timestamp;
}
public String DisplayPost() {
	return GenerateHeader() + this.content + GenerateTags();
}

private String GenerateHeader() {
	return "@" + this.timestamp.format(DateTimeFormatter.ofPattern("hh:mm a"))+": ";
}
private String GenerateTags() {
	String generatedTags = "";
	for(String tag : alwaysTag) {
		generatedTags += "#" + tag;
	}
	return generatedTags;
}
}
