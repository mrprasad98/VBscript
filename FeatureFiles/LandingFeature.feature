Feature: LandingFeature
Scenario: Landing into Buzgilla Main Page

Given User should use Buzgilla URL
When User clicked on Enter Bug link
Then User should be at Enter Bug Page
When User provides data as Severity, Hardware, OS, Summary and Description


