﻿using WiredBrainCoffee.DataProcessor.Parsing;

namespace WiredBrainCoffee.DataProcessTests;

public class CsvLineParserTests
{
  [Fact]
  public void ShouldParseValidLine()
  {
    string[] csvLines = new[] { "Cappuccino;10/27/2022 8:06:04 AM" };

    CsvLineParser.Parse(csvLines);

    var machineDataItems = CsvLineParser.Parse(csvLines);

    Assert.NotNull(machineDataItems);
    Assert.Single(machineDataItems);
    Assert.Equal("Cappuccino", machineDataItems[0].CoffeeType);
    Assert.Equal(new DateTime(2022, 10, 27, 8, 6, 4), machineDataItems[0].CreatedAt);
  }
}
