using System;
using NUnit.Framework;
using NUnit.Framework.Internal;

public class HeroRepositoryTests
{
    private HeroRepository heroRepository;
    private Hero hero;
    [SetUp]
    public void SetUp()
    {
         heroRepository = new HeroRepository();
         hero = new Hero("Pesho",10);
    }
    [Test]
    public void ConstrictorWorkCorrectly()
    {
        var heroRepository = new HeroRepository();
        Assert.IsNotNull(heroRepository.Heroes);
    }

    [Test]
    public void TestCreateMethodWorkCorrectly()
    {
        heroRepository.Create(hero);
        Assert.AreEqual(1,heroRepository.Heroes.Count);
    }

    [Test]
    public void CreateMethodThrowExceptionWith()
    {
        heroRepository.Create(hero);
        Assert.Throws<ArgumentNullException>((() => heroRepository.Create(null)));
        Assert.Throws<InvalidOperationException>((() => heroRepository.Create(new Hero("Pesho",1))));
    }

    [Test]
    public void RemoveMethodWorkCorrectly()
    {
        heroRepository.Create(hero);
        heroRepository.Remove(hero.Name);
        Assert.AreEqual(0,heroRepository.Heroes.Count);
    }
    //TODO:CreateMethodReturnString
    //TODO:RemoveMethodReturnFalse
    [Test]
    public void REmoveMethodThrowExceptionWithNullRefernce()
    {
        Assert.Throws<ArgumentNullException>((() => heroRepository.Remove(null)));
    }

    [Test]
    public void GetHeroWithHighestLevelWorkCorrectly()
    {
        heroRepository.Create(hero);
        heroRepository.Create(new Hero("gosho", 22));
        heroRepository.Create(new Hero("Kotka", 1));
        var heigstlevelHeero = heroRepository.GetHeroWithHighestLevel();
        Assert.AreEqual("gosho", heigstlevelHeero.Name);
        Assert.AreEqual(22,heigstlevelHeero.Level);
    }

    [Test]
    public void GetHeroWorkCorrectly()
    {
        heroRepository.Create(hero);
        var currHero = heroRepository.GetHero(hero.Name);
        Assert.AreEqual(hero.Name,currHero.Name);
        Assert.AreEqual(hero.Level, currHero.Level);

    }
}