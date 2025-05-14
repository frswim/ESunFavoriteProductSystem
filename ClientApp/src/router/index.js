import { createRouter, createWebHistory } from 'vue-router'
import HomeView from '../views/HomeView.vue'
import AddLike from '../views/AddLike.vue'
import EditLike from '../views/EditLike.vue'

const routes = [
  { path: '/', name: 'Home', component: HomeView },
  { path: '/add', name: 'AddLike', component: AddLike },
  { path: '/edit/:id', name: 'EditLike', component: EditLike }
]

export default createRouter({
  history: createWebHistory(),
  routes
})
