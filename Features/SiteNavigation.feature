Feature: Site Navigation
    In order to navigate website pages
    I need to be able to click on navigation

  Scenario Outline: Going to some page                    
    Given I am on home page                  
    When I click on <button>                     
    Then the page should be <title>

    Examples: 
    | button       | title                             |
    | how we do it | https://www.epam.com/how-we-do-it |
    | insights     | https://www.epam.com/insights     |
