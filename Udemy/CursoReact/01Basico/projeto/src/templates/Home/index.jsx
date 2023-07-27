import { Component } from 'react';

import './style.css';

import { loadPosts } from '../../utils/load-post';
import { Posts } from '../../components/Posts';

export class Home extends Component {
  state = {
    posts: [],
    allPosts: [],
    page: 0,
    postsPerPage: 2,
  }


  async componentDidMount() {
    await this.loadPosts()
  }

  loadPosts = async () => {
    const {page, postsPerPage} = this.state

    const postsAndPhotos = await loadPosts();
    this.setState({
      posts: postsAndPhotos.slice(page, postsPerPage),
      allPosts: postsAndPhotos
    })
  }

  loadMorePosts = () => {
    console.log('Load more posts chamado')
  }

  render() {
    const { posts } = this.state;

    return (
      <section className='container'>
        <Posts posts={posts} />

        <button>Load more posts</button>
      </section>

    )
  }
}


export default Home;
