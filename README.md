# Backpack.Tf Api


[Backpack.Tf Api](https://github.com/jackofdiamond5/BackpackTfApi) is a project that provides wrapper models and utility classes for easier management for the [backpack.tf](https://backpack.tf) API endpoints. Built with the mindset of being useful for all sorts of applications, it lives to serve the following goals:
- Be easy to use and understand
- Be well documented
- Unify all API endpoints and provide simple handlers
- Provide simple ways of serialization and deserialization
- Internally handle all API calls but also expose functionality for custom implementations
- Offer simple ways of handling the various responses and transform them into .NET types

# Included features

## Handlers
|Name|Description
|:---|:----|
|WebAPI Economy|Item prices and currencies manager|
|WebAPI Users|[backpack.tf](https://backpack.tf) users manager|
|SteamUser|[Steam](https://store.steampowered.com) users manager|
|UserToken|Manager for endpoints that work with access tokens|

## Models 
|Handler|Endpoint|Description
|:--------------------------|:------------------------|:---|
|WebAPI Economy|Currencies|Contains information for all of the available currencies.
|WebAPI Economy|PriceHistory|Price history for item(s).
|WebAPI Economy|Prices|Handles prices for all Team Fortress 2 items.
|WebAPI Economy|SpecialItems|Contains information for special items.
|WebAPI Users|WebUsers|Contains models for users at [backpack.tf](https://backpack.tf)
|WebAPI Users|WebImpersonatedUsers|Contains models for impersinated users at [backpack.tf](https://backpack.tf)
|SteamUser|UserInventory|Handles calls to [Steam](https://store.steampowered.com)'s inventory API endpoint. 
|UserToken|ClassifiedsSearch|Models for searching [backpack.tf](https://backpack.tf) classifieds.
|UserToken|ListingsCreator|Models for handling input and response when creating classifieds.
|UserToken|UserListings|Models for searching a specific user's classifieds.
|UserToken|Users|Models containing information about a specific user.

## Utilities
|Handler|Endpoint|Utility|Description
|:-----|:--------------------------|:------------------------|:--|
|WebAPI Economy|Currencies|CurrenciesHandler|Exposes static methods for handling the Currencies endpoint.
|WebAPI Economy|Prices|ItemsHandler|Exposes static methods for navigating the Prices endpoint.
|SteamUser|UserInventory|InventoryHandler|Exposes static methods for fetching data such as asset and/or description objects from the UserInventory endpoint.
|UserToken|ClassifiedsSearch|ClassifiedsSearchHandler|Exposes static methods for obtaining classifieds information from the ClassifiedsSearch endpoint.
|UserToken|UserListings, ListingsCreator|UserListingsHandler|Exposes static methods for creating and searching for a user's classifieds.
|UserToken|Users|UsersDataHandler|Exposes static functions for navigating the Users endpoint.

## Main User Model


## Examples
