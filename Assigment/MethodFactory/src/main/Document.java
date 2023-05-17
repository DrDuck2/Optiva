package main;
import java.util.List;
import java.util.ArrayList;

abstract class Document {
private List<Page> pages = new ArrayList<>();

public List<Page> Pages(){
	return pages;
}

public Document() {
	this.CreatePages();
}

protected abstract void CreatePages();
}
