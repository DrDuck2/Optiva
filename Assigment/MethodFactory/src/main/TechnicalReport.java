package main;

public class TechnicalReport extends Document {
@Override
public void CreatePages() {
	Pages().add(new EducationPage());
	Pages().add(new IntroductionPage());
	Pages().add(new SkillsPage());
}
}
