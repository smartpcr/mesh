Feature: FibonacciNumber

    As a user
    I want to get a list of fibonacci numbers

    Scenario Outline: Find fibonacci number
        Given I want to get <nth> fibonacci number
        When I execute the service
        Then I should get the following <fibonacciNumber>

        Examples:
            | nth | fibonacciNumber |
            | 0   | 0               |
            | 1   | 1               |
            | 2   | 1               |
            | 3   | 2               |
            | 4   | 3               |
            | 5   | 5               |
            | 6   | 8               |
            | 7   | 13              |
            | 8   | 21              |
            | 9   | 34              |
            | 10  | 55              |