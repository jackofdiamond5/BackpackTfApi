[![NuGetVersion](https://img.shields.io/nuget/v/BackpackTfApi.svg)](https://www.nuget.org/packages/BackpackTfApi)
[![BuildStatus](https://travis-ci.com/jackofdiamond5/BackpackTfApi.svg?branch=master)](https://travis-ci.org/jackofdiamond5/BackpackTfApi)
# Backpack.Tf Api

[Backpack.Tf Api](https://github.com/jackofdiamond5/BackpackTfApi) is a project that provides wrapper models and utility classes for easier management of the [backpack.tf](https://backpack.tf) API endpoints. Built with the mindset of being useful for all sorts of applications, it lives to serve the following goals:
- Be easy to use and understand
- Be well documented
- Unify all API endpoints and provide easy to use handlers
- Support serialization and deserialization
- Internally handle all API calls, but also expose functionality for custom implementations
- Offer ways of working with the various JSON response objects and transform them into .NET types

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
|WebAPI Users|WebImpersonatedUsers|Contains models for impersonated users at [backpack.tf](https://backpack.tf)
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
- The main user model is intended to be the entry point for all API calls.

|Member Name|Type|Description
|:---|:----|:--|
|SteamId64|Property|The Steam ID associated with a steam account.
|ApiKey|Property|The API key prvided by [backpack.tf](https://backpack.tf)
|AccessToken|Property|The access token provided by [backpack.tf](https://backpack.tf)
|GetCurrencies|Method|Returns internal currency data for Team Fortress 2|
|GetPriceHistory|Method|Returns price history for the specified item.
|GetItemPrices|Method|Fetches item prices for the specified API key. A request may be sent once every 60 seconds.
|GetSpecialitems|Method|Gets special items for the specified API key.
|GetUsersByIds|Method|Fetch users data for an array of SteamId64-s.
|GetImpersonatedUsers|Method|Get impersonated users for a user's SteamId64.
|GetClassifieds|Method|Fetches all currently open classifieds that are on [backpack.tf](https://backpack.tf)
|GetOwnClassifieds|Method|Fetches the currently opened user's classifieds from [backpack.tf](https://backpack.tf)
|CreateSellListing|Method|Creates a sell listing / classified on [backpack.tf](https://backpack.tf)
|CreateBuyListing|Method|Creates a buy listing / classified on [backpack.tf](https://backpack.tf)
|GetUserInventory|Method|Fetches a user's inventory.
|GetOwnInventory|Method|Fetches the current user's inventory.
|GetItemFromInventory|Method|Searches for an item in the user's inventory and returns its Asset and Description models.

## Custom Exceptions
|Name|Description
|:--|:--|
|ClassifiedCreationFailureException|Thrown when something internally prevented the classified from being created. If  [backpack.tf](https://backpack.tf) declined the creation of the classified, the exception is not thrown.
|ItemNotFoundException|Thrown if an item could not be located. It is currently used mainly for the user's inventory.
|InventoryNullException|Thrown if GetItemFromInventory is called when the user's inventory is null.

## Setup

Open your package manager console and run:
```
Install-Package BackpackTfApi -Version 1.0.3
```

# Examples
```c#
// Instantiate the main user model
var bptfUser = new BackpackTfUser("mySteamId64", "myBackpackTfApiKey", "myBackpackTfAccessToken");
 
// See your own listings
var myOpenClassifieds = bptfUser.GetOwnClassifieds();

// See your inventory
// The returned Response object will contain all items in your inventory.
var myInventory = bptfUser.GetOwnInventory();

// Get an item from your inventory
// The returned InventoryItem object contains the item's Asset and Description models.
var targetItem = bptfUser.GetItemFromInventory("Madame Dixie");

// Create a new sell classified by typing the item manually
// The returned Response object will contain information on whether the classified was successfully created or not.
// NOTE: You must have the item in your inventory or else ItemNotFoundException is thrown
var responseSellListing = bptfUser.CreateSellListing("Madame Dixie", "metal", 5, "I want to sell this item! :)");

// Overloads for CreateBuyListing and CreateSellListing are suppored where you pass in an InventoryItem.
var responseSellListing = bptfUser.CreateBuyListing(targetItem, "metal", 5, "I want to buy this item! :)");
```

