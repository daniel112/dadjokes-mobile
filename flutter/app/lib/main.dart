import 'package:app/screens/home.dart';
import 'package:flutter/material.dart';

void main() => runApp(const MyApp());

class MyApp extends StatelessWidget {
  const MyApp({Key? key}) : super(key: key);

  // This widget is the root of your application.
  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      title: 'Flutter Demo',
      theme: ThemeData(
        primarySwatch: Colors.blue,
      ),
      home: const MyHomePage(),
    );
  }
}

class MyHomePage extends StatefulWidget {
  const MyHomePage({Key? key}) : super(key: key);

  @override
  State<MyHomePage> createState() => _MyHomePageState();
}

/// Models
class NavigationItem {
  final String title;
  final Icon icon;
  final Widget screen;
  
  const NavigationItem(this.title, this.icon, this.screen);

  BottomNavigationBarItem navigationBarItem() {
    return BottomNavigationBarItem(icon: icon,label: title);
  }
}

class _MyHomePageState extends State<MyHomePage> {
  int _selectedIndex = 0;
  static const List<NavigationItem> _screens = [
    NavigationItem("Home", Icon(Icons.home), Home()),
    NavigationItem("History", Icon(Icons.history), Home())
  ];

  void _onItemTapped(int index) {
    setState(() {
      _selectedIndex = index;
    });
  }
  @override
  Widget build(BuildContext context) {
  
    return Scaffold(
      appBar: AppBar(
        title: Text(_screens.elementAt(_selectedIndex).title),
      ),
      body:  _screens.elementAt(_selectedIndex).screen,
      bottomNavigationBar: BottomNavigationBar(
        items: _screens.map((screen) => screen.navigationBarItem()).toList(),
        currentIndex: _selectedIndex,
        selectedItemColor: Colors.amber[800],
        onTap: _onItemTapped,
      ),
    );
  }
}
