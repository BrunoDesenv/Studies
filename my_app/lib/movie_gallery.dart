import 'package:flutter/material.dart';
import 'package:my_app/movie_detail.dart';

class MovieGallery extends StatelessWidget {
  const MovieGallery({Key? key}) : super(key: key);

  Widget _moviesGrid(BuildContext context) {
    return GridView.count(
        crossAxisCount: 2,
        padding: const EdgeInsets.all(10),
        mainAxisSpacing: 10,
        crossAxisSpacing: 10,
        children: _buildGridTileList(context, 10));
  }

  List<InkWell> _buildGridTileList(BuildContext context, int count) {
    var _colors = [
      Colors.red,
      Colors.yellow,
      Colors.orange,
      Colors.white,
      Colors.grey,
      Colors.green,
      Colors.pink,
      Colors.purple,
      Colors.blue,
      Colors.black,
      Colors.red,
    ];

    return List.generate(
        count,
        (index) => InkWell(
            child: Container(color: _colors[index]),
            onTap: () => _openDetailsPage(context, index)));
  }

  _openDetailsPage(BuildContext context, int index) {
    Navigator.push(context,
        MaterialPageRoute(builder: (context) => MovieDetail(index: index)));
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(title: const Text("Filmes em destaque")),
      body: Container(
        color: Colors.black87,
        child: _moviesGrid(context),
      ),
    );
  }
}
