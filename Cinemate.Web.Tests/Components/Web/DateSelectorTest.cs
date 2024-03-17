using Bunit;
using Microsoft.AspNetCore.Components;
using NUnit.Framework;
using System;
using System.Globalization;
using System.Threading.Tasks;
using Cinemate.Web.Components.Web;
using Microsoft.AspNetCore.Components.Web;


namespace Cinemate.Web.Tests.Components.Web;

[TestFixture]
public class DateSelectorTest
{
    private Bunit.TestContext testContext;

    [SetUp]
    public void SetUp()
    {
        testContext = new Bunit.TestContext();
    }

    [TearDown]
    public void TearDown()
    {
        testContext.Dispose();
    }

    [Test]
    public async Task DateSelector_InitializesWithTodaysDateSelected()
    {
        var component = testContext.RenderComponent<DateSelector>();

        var todayButton = component.Find("button.selected");

        Assert.That(todayButton, Is.Not.Null);
        Assert.That(todayButton.TextContent.Trim(), Is.EqualTo("VANDAAG"));
    }

    [Test]
    public async Task DateSelector_SelectFutureDate_TriggersOnDateSelected()
    {
        DateTime? callbackInvokedWithDate = null;
        var component = testContext.RenderComponent<DateSelector>(parameters => parameters
            .Add(p => p.OnDateSelected, EventCallback.Factory.Create<DateTime>(
                this, 
                date => callbackInvokedWithDate = date)));
    
        var futureDate = DateTime.Now.AddDays(3);
        var futureDateString = futureDate.ToString("ddd dd MMM", CultureInfo.CreateSpecificCulture("nl-NL"));
        var futureDateButton = component.Find($"button:contains('{futureDateString}')");

        await futureDateButton.ClickAsync(new MouseEventArgs()); // Fixed here

        Assert.That(callbackInvokedWithDate, Is.Not.Null);
        Assert.That(callbackInvokedWithDate.Value.Date, Is.EqualTo(futureDate.Date));
    }


}