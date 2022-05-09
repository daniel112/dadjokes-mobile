import { StyleSheet, TouchableOpacity } from "react-native";
import { useState } from "react";
import { Text, View } from "../components/Themed";
import Colors from "../constants/Colors";

export default function HomeScreen() {
  const [joke, setJoke] = useState("Press the button for dad jokes!");

  return (
    <View style={styles.container}>
      <View>
        <View style={styles.jokeContainer}>
          <Text
            style={styles.jokeText}
            lightColor="rgba(0,0,0,0.8)"
            darkColor="rgba(255,255,255,0.8)"
          >
            {joke}
          </Text>
        </View>

        <View style={styles.ctaContainer}>
          <TouchableOpacity
            onPress={async () => {
              try {
                const result = await fetch("https://icanhazdadjoke.com/", {
                  method: "GET",
                  headers: {
                    Accept: "application/json",
                  },
                });
                const json = await result.json();
                setJoke(json.joke);
              } catch (error) {
                console.log("ERRROR: ", error);
              }
            }}
            style={styles.button}
          >
            <Text style={styles.buttonText} lightColor={"white"}>
              FETCH
            </Text>
          </TouchableOpacity>
        </View>
      </View>
    </View>
  );
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    alignItems: "center",
    justifyContent: "center",
  },
  jokeContainer: {
    alignItems: "center",
    marginHorizontal: 50,
  },
  jokeText: {
    fontSize: 17,
    lineHeight: 24,
    textAlign: "center",
  },
  ctaContainer: {
    marginTop: 15,
    marginHorizontal: 20,
    alignItems: "center",
  },
  button: {
    paddingVertical: 15,
    backgroundColor: Colors.light.primary,
    width: "100%",
    borderRadius: 4,
    shadowOpacity: 0.15,
  },
  buttonText: {
    textAlign: "center",
  },
});
