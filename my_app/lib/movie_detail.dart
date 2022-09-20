import 'package:flutter/material.dart';

class MovieDetail extends StatelessWidget {
  const MovieDetail({Key? key, required this.index}) : super(key: key);
  final int index;
  @override
  Widget build(BuildContext context) {
    return Scaffold(
        appBar: AppBar(title: Text("Detalhe do filme $index")),
        body: Container(
            constraints: const BoxConstraints.expand(),
            color: Colors.black87,
            child: SingleChildScrollView(
                child: Container(
              child: Column(children: [
                Row(children: [
                  Expanded(
                      child: Container(
                          color: Colors.yellow,
                          constraints: const BoxConstraints(minHeight: 180))),
                ]),
                Padding(
                    padding: const EdgeInsets.all(20),
                    child: Column(children: [
                      Row(
                        children: const [
                          Expanded(
                              child: Text("Título do filme",
                                  style: TextStyle(
                                      color: Colors.white, fontSize: 18)))
                        ],
                      ),
                      Row(
                        children: const [
                          Expanded(
                              child: Text("01/01/2022",
                                  style: TextStyle(
                                      color: Colors.white, fontSize: 14))),
                          Text(
                            "7.9",
                            style: TextStyle(color: Colors.white, fontSize: 14),
                          ),
                          Icon(
                            Icons.star,
                            color: Colors.white,
                          )
                        ],
                      ),
                      const SizedBox(height: 40),
                      Row(
                        children: const [
                          Expanded(
                              child: Text(
                            "is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                            style: TextStyle(color: Colors.white, fontSize: 16),
                          ))
                        ],
                      )
                    ])),
              ]),
            ))));
  }
}
