package main;

public class Resume extends Document {
@Override
public void CreatePages() {
	Pages().add(new EducationPage());
	Pages().add(new IntroductionPage());
}
}
