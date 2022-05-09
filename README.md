# Summary

- A simple mobile app created 3 different times with:
  - [Flutter](https://docs.flutter.dev/get-started/install/macos)
  - [React Native (Expo)](https://docs.expo.dev/get-started/installation/)
  - [Xamarin (Forms)](https://dotnet.microsoft.com/en-us/learn/xamarin/hello-world-tutorial/install)

All three solutions provide similar UI building experience of using building blocks (Widgets, Components, Xml) to put together a View heirarchy.

## App Features

- Simple tab navigation

  - Home - Fetch dadJoke from [Dadjoke API](https://icanhazdadjoke.com/api)
  - History - shows a list of past dadJoke item(s)

- Material Icon for tab images

<img src="./images/2022-05-08-15-36-26.png" alt="Home" width="200"/>

## Measurement

General categories of how I would score each framework based on my experience

- **Ease of getting started** (boilerplate code, documentation, technical requirements)
- **Developer support** (open source, community, documentation)
- **Developer experience** (native support, debugging, flexibility)

## TODO:

- [ ] Performance comparison
- [ ] App artifacts size

# Summary

## Flutter

- **Language**: Dart
- **Package manager**: https://pub.dev/
- **Common design pattern**: BLoC

### Personal Ratings

[See the README](./flutter/app/README.md) for more details

**Ease of getting started**: <img src="https://raw.githubusercontent.com/FortAwesome/Font-Awesome/6.x/svgs/solid/star.svg" width="20" height="20"><img src="https://raw.githubusercontent.com/FortAwesome/Font-Awesome/6.x/svgs/solid/star.svg" width="20" height="20"> <img src="https://raw.githubusercontent.com/FortAwesome/Font-Awesome/6.x/svgs/solid/star.svg" width="20" height="20"><img src="https://raw.githubusercontent.com/FortAwesome/Font-Awesome/6.x/svgs/solid/star.svg" width="20" height="20"><img src="https://raw.githubusercontent.com/FortAwesome/Font-Awesome/6.x/svgs/solid/star.svg" width="20" height="20">

- Flutter provides great onboarding experience with the CLI tooling
- Noticeably faster to setup than ReactNative and Xamarin projects

**Developer Support**: <img src="https://raw.githubusercontent.com/FortAwesome/Font-Awesome/6.x/svgs/solid/star.svg" width="20" height="20"><img src="https://raw.githubusercontent.com/FortAwesome/Font-Awesome/6.x/svgs/solid/star.svg" width="20" height="20"> <img src="https://raw.githubusercontent.com/FortAwesome/Font-Awesome/6.x/svgs/solid/star.svg" width="20" height="20"><img src="https://raw.githubusercontent.com/FortAwesome/Font-Awesome/6.x/svgs/solid/star.svg" width="20" height="20"><img src="https://raw.githubusercontent.com/FortAwesome/Font-Awesome/6.x/svgs/regular/star.svg" width="20" height="20">

- There's a lot of activity in the community, comparable to the `React Native` community.
- Official documentations are very thorough.
- Has good open source libs to use.

**Developer Experience**: <img src="https://raw.githubusercontent.com/FortAwesome/Font-Awesome/6.x/svgs/solid/star.svg" width="20" height="20"><img src="https://raw.githubusercontent.com/FortAwesome/Font-Awesome/6.x/svgs/solid/star.svg" width="20" height="20"> <img src="https://raw.githubusercontent.com/FortAwesome/Font-Awesome/6.x/svgs/solid/star.svg" width="20" height="20"><img src="https://raw.githubusercontent.com/FortAwesome/Font-Awesome/6.x/svgs/solid/star.svg" width="20" height="20"><img src="https://raw.githubusercontent.com/FortAwesome/Font-Awesome/6.x/svgs/regular/star.svg" width="20" height="20">

- Developer docs are very detailed and thorough.
- Pre-packaged debugging tool is very intuitive and easy to understand
- Some widgets provides out of the box support for complex functionality
- Provides great typing system that prevents runtime error

## React Native (Expo)

- **Language**: Javascript/Typescript
- **Framework**: React
- **Package manager**: npm/yarn
- **Common design pattern**: Redux

## Xamarin Forms

- **Language**: C#/F#
- **Framework**: .NET
- **Package manager**: Nuget
- **Common design pattern**: MVVM

### Personal Ratings

[See the README](./xamarin/README.md) for more details

**Ease of getting started**: <img src="https://raw.githubusercontent.com/FortAwesome/Font-Awesome/6.x/svgs/solid/star.svg" width="20" height="20"><img src="https://raw.githubusercontent.com/FortAwesome/Font-Awesome/6.x/svgs/solid/star.svg" width="20" height="20"> <img src="https://raw.githubusercontent.com/FortAwesome/Font-Awesome/6.x/svgs/solid/star.svg" width="20" height="20"><img src="https://raw.githubusercontent.com/FortAwesome/Font-Awesome/6.x/svgs/regular/star.svg" width="20" height="20"><img src="https://raw.githubusercontent.com/FortAwesome/Font-Awesome/6.x/svgs/regular/star.svg" width="20" height="20">

- Forced to use Visual Studio IDE. Auto imports felt a bit off at times.
- Boilerplate code wasn't able to be executed right away
  - Forced to have latest XCode version (not backwards compatible friendly)

**Developer Support**: <img src="https://raw.githubusercontent.com/FortAwesome/Font-Awesome/6.x/svgs/solid/star.svg" width="20" height="20"><img src="https://raw.githubusercontent.com/FortAwesome/Font-Awesome/6.x/svgs/solid/star.svg" width="20" height="20"> <img src="https://raw.githubusercontent.com/FortAwesome/Font-Awesome/6.x/svgs/solid/star.svg" width="20" height="20"><img src="https://raw.githubusercontent.com/FortAwesome/Font-Awesome/6.x/svgs/regular/star.svg" width="20" height="20"><img src="https://raw.githubusercontent.com/FortAwesome/Font-Awesome/6.x/svgs/regular/star.svg" width="20" height="20">

- Official documentation was very basic
- A lot of the community posts and questions are outdated
- Limited amount of open source plugins
- Very dependent on Xamarin team to stay up to date with platform changes

**Developer Experience**: <img src="https://raw.githubusercontent.com/FortAwesome/Font-Awesome/6.x/svgs/solid/star.svg" width="20" height="20"><img src="https://raw.githubusercontent.com/FortAwesome/Font-Awesome/6.x/svgs/solid/star.svg" width="20" height="20"> <img src="https://raw.githubusercontent.com/FortAwesome/Font-Awesome/6.x/svgs/regular/star.svg" width="20" height="20"><img src="https://raw.githubusercontent.com/FortAwesome/Font-Awesome/6.x/svgs/regular/star.svg" width="20" height="20"><img src="https://raw.githubusercontent.com/FortAwesome/Font-Awesome/6.x/svgs/regular/star.svg" width="20" height="20">

- Great MVVM support
- Very basic documentation and little to no code documentation.
- Hot reloading only works with XAML changes
