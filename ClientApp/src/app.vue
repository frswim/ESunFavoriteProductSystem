<template>
  <div class="container mt-4">
    <h1 class="text-center">ESUN Favorite Product System</h1>
    <router-view />
  </div>
</template>

<script>
export default {
  name: 'App'
}
</script>

<script>
import Header from './components/Header.vue'
export default { components: { Header } }
</script>

