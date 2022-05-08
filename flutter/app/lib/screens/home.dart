import 'dart:convert';
import 'package:flutter/material.dart';
import 'package:http/http.dart' as http;

class Home extends StatefulWidget {
  const Home({Key? key}) : super(key: key);

  @override
  _Home createState() => _Home();

}

class _Home extends State<Home> {
  DadJoke? dadJoke;

  Future<void> _onPressed() async {
    DadJoke result = await fetchDadJoke();
    setState(() {
      dadJoke = result;
    });
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      body: SafeArea(
        child: Center(
          child: Padding(
            padding: const EdgeInsets.only(right: 20.0, left: 20.0),
            child: Column(
              children: [
                Padding(
                  padding: const EdgeInsets.only(bottom: 20.0),
                  child: Text(
                    dadJoke?.joke ?? "Press the button for dad jokes!", 
                    textAlign: TextAlign.center,
                    style: DefaultTextStyle.of(context).style.apply(fontSizeFactor: 2.0),
                  ),
                ),
                ElevatedButton(
                  onPressed: _onPressed, 
                  child: const Text('FETCH'),
                  style: ElevatedButton.styleFrom(
                    minimumSize: const Size.fromHeight(50), 
                  ),
                )
              ],
            mainAxisSize: MainAxisSize.min,
            ),
          )
        ),
      )
    );
  }
}

/// TODO: cleanup with BLoC
class DadJoke {
  final String joke;
  final String id;
  const DadJoke({required this.joke, required this.id});

  factory DadJoke.fromJson(Map<String, dynamic> json) {
    return DadJoke(joke: json['joke'], id: json['id']);
  }
}

Future<DadJoke> fetchDadJoke() async {
  final response = await http.get(Uri.parse('https://icanhazdadjoke.com/'), headers: {"Accept": "application/json"});

  if (response.statusCode == 200) {
    // If the server did return a 200 OK response,
    // then parse the JSON.
    return DadJoke.fromJson(jsonDecode(response.body));
  } else {
    // If the server did not return a 200 OK response,
    // then throw an exception.
    throw Exception('Failed to load joke');
  }
}