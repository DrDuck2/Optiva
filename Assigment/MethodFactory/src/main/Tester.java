package main;

public class Tester{
	public static void Test()
	{
		Document[] documents = new Document[] {new Resume(),new TechnicalReport()};
		for(Document document : documents) {
			System.out.println(document.getClass().getSimpleName()+":");
			for(Page page : document.Pages()) {
				System.out.println("\t"+page.getClass().getSimpleName());
			}
			System.out.println();
		}
	}
}
